using Microsoft.EntityFrameworkCore;
using ShokouhApp.Model;

namespace ShokouhApp.Services
{
    public class FinancialService
    {
        readonly MyDbContext _dbConntext;

        public FinancialService(MyDbContext dbConntext)
        {
            _dbConntext = dbConntext;
        }

        public void AccountTransaction(int studentId, int termId, int amount, string? shortTransKey, string? description)
        {
            var stuAccountingCode = CreateOrGetStudentCode(studentId);

            var sumDebit = _dbConntext.ShokouhPardisAccountingTransactions
                                    .Where(x => x.Code == stuAccountingCode.Code && x.TermId == termId)
                                    .Sum(x => x.Debit);
            var sumCredit = _dbConntext.ShokouhPardisAccountingTransactions
                                    .Where(x => x.Code == stuAccountingCode.Code && x.TermId == termId)
                                    .Sum(x => x.Credit);
            var curBalance = sumCredit - sumDebit;

            var debit = 0;
            var credit = 0;
            if (amount > 0) credit = amount; else debit = Math.Abs(amount);
            var bal = curBalance + credit - debit;
            var tx = new ShokouhPardisAccountingTransaction
            {
                TermId = termId,
                ShortTxKey = shortTransKey,
                Debit = debit,
                Credit = credit,
                Description = description,
                AccountingCodeFk = stuAccountingCode.AccountingCodeId,
                Code = stuAccountingCode.Code,
                SubjectRecFk = studentId,
                Balance = bal
            };
            _dbConntext.ShokouhPardisAccountingTransactions.Add(tx);

        }

        public int? PaymentBalanceFor(string? shortTransKey, int studentId, int termId)
        {
            var sum = _dbConntext.ShokouhPardisAccountingTransactions.Where(x =>
                   x.AccountingCodeFk == 4 &&
                   x.SubjectRecFk == studentId &&
                   x.TermId == termId &&
                   x.ShortTxKey == shortTransKey)
                .Sum(x => x.Credit - x.Debit);
            return sum;
        }

        public void ApplyDailyJv(ShokouhPardisDailyJv djv)
        {
            // var price = _dbConntext.ShokouhPardisLevelBookPrices.FirstOrDefault(x => x.TermId == termId && x.LevelId == levelId);
            // if (price == null)
            //     throw new Exception("چرا پس رکورد مبلغ برای این ترم یا سطح وجود ندارد؟");

            // var jvs = _dbConntext.ShokouhPardisDailyJvs.Where(x => x.StudentId == studentId && x.TermId == termId);
            // var sumTuition = jvs.Where(x => x.FeeFor.Contains("شهریه")).Sum(x=>x.Fee);
            // var sumBook = jvs.Where(x => x.FeeFor.Contains("کتاب")).Sum(x=>x.Fee);
            //     if (sumTuition >= price.TuitionAmount)
            // {
            //     // TODO: شهریه کامل پرداخت شده
            // }

            AccountTransaction(djv.StudentId, djv.TermId, djv.Fee, djv.FeeFor, "Transaction from JV-ID : " + djv.DailyJvid);

            //_dbConntext.ShokouhPardisTimeTableStudents.

        }

        ShokouhPardisAccountingCode CreateOrGetStudentCode(int studentId)
        {
            ShokouhPardisAccountingCode? code = _dbConntext.ShokouhPardisAccountingCodes.FirstOrDefault(x => x.AccountingCodeParentId == 4 && x.SubjectRecFk == studentId);
            if (code != null)
                return code;

            ShokouhPardisAccountingCode newCode = null;
            using var trans = _dbConntext.Database.BeginTransaction();
            try
            {
                var studentRefCode = _dbConntext.ShokouhPardisAccountingCodes
                    .Single(x => x.AccountingCodeId == 4);

                studentRefCode.LastSq += 1;

                var coding = studentRefCode.LastSq!.ToString().PadLeft(5, '0');
                var student = _dbConntext.ShokouhPardisStudentClasses
                    .Single(x => x.StudentClassId == studentId);

                newCode = new ShokouhPardisAccountingCode()
                {
                    SubjectRecFk = studentId,
                    Title = $"{student.StudentName} - {student.StudentFamily}",
                    Code = studentRefCode.Code + coding,
                    AccountingCodeParentId = 4
                };

                _dbConntext.SaveChanges();
                trans.Commit();
            }
            catch (Exception e)
            {
                trans.Rollback();
            }

            return newCode;
        }
    }
}
