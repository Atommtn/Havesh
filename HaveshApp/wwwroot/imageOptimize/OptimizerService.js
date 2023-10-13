var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var imageCompression;
var JSInteropWithTypeScript;
(function (JSInteropWithTypeScript) {
    class ImageFunctions {
        constructor() {
            this.zipedData = new Map();
        }
        handleImageUpload(promiseHandler, elementId) {
            return __awaiter(this, void 0, void 0, function* () {
                const fUpload = document.getElementById(elementId);
                const imageFile = fUpload.files[0];
                const options = {
                    maxSizeMB: .7,
                    maxWidthOrHeight: 1024,
                    useWebWorker: true
                };
                const compressedFile = yield imageCompression(imageFile, options);
                const arr = yield compressedFile.arrayBuffer();
                this.zipedData.set(elementId, new Uint8Array(arr));
                promiseHandler.invokeMethodAsync('GetDataStream');
            });
        }
        GetCompresedImageDataStream(elementId) {
            return this.zipedData.get(elementId);
        }
    }
    function Load() {
        window['imgCls'] = new ImageFunctions();
    }
    JSInteropWithTypeScript.Load = Load;
})(JSInteropWithTypeScript || (JSInteropWithTypeScript = {}));
JSInteropWithTypeScript.Load();
//# sourceMappingURL=OptimizerService.js.map