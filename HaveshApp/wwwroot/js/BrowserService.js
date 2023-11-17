window.blazorExtensions = {

    SetCookie: function (name, value, days) {

        var expires;
        if (days) {
            const date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = `; expires=${date.toGMTString()}`;
        } else {
            expires = "";
        }
        document.cookie = name + "=" + (value || "") + expires + "; path=/";
    },

    GetCookie: function (name) {
        const nameEq = name + "=";
        const ca = document.cookie.split(';');
        for (let i = 0; i < ca.length; i++) {
            let c = ca[i];
            while (c.charAt(0) === ' ') c = c.substring(1, c.length);
            if (c.indexOf(nameEq) === 0) return c.substring(nameEq.length, c.length);
        }
        return null;
    },

    EraseCookie: function (name) {
        console.log("Erades !!!");
        document.cookie = name + '=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;';
    },

    OpenInNewTab: function (url) {
        const newTab = window.open(url, '_blank');
        newTab.focus();
    },
    OpenInCurrentTab: function (url) {
        const newTab = window.open(url, '_self');
        newTab.focus();
    },

    PrintPage: function() {
        window.print();
    }
}
