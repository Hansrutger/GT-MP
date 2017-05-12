API.onServerEventTrigger.connect(function (eventName, args) {
    switch (eventName) {
        case 'testjs':
            TestHandler();
            break;
    }

});

var browser = null;
function TestHandler() {
    var res = API.getScreenResolution();
    browser = API.createCefBrowser(500, 499);
    API.waitUntilCefBrowserInit(browser);
    API.setCefBrowserPosition(browser, (res.Width / 2) - (500 / 2), (res.Height / 2) - (499 / 2));
    API.loadPageCefBrowser(browser, "Designs/blackbox.html");
    API.showCursor(true);
    API.setCanOpenChat(false);
}

function BtnClicked() {
    API.showCursor(false);
    API.setCanOpenChat(true);
    API.destroyCefBrowser(browser);
    API.triggerServerEvent("BackToTheFuture");
}