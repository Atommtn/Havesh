window.updateMessageCaller = (dotNetHelper) => {
    dotNetHelper.invokeMethodAsync('ShokouhApp', 'UpdateMessageCaller');
    dotNetHelper.dispose();
}