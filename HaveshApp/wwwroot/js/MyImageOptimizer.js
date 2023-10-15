window.updateMessageCaller = (dotNetHelper) => {
    dotNetHelper.invokeMethodAsync('HaveshApp', 'UpdateMessageCaller');
    dotNetHelper.dispose();
}