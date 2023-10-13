var imageCompression: any;

namespace JSInteropWithTypeScript {

    class ImageFunctions {
        zipedData: Map<string,Uint8Array>;

        constructor() {
            this.zipedData = new Map<string, Uint8Array>();
        }

        public async handleImageUpload(promiseHandler,elementId) {
            const fUpload = document.getElementById(elementId) as any;
            const imageFile = fUpload.files[0];

            const options = {
                maxSizeMB: .7,
                maxWidthOrHeight: 1024,
                useWebWorker: true
            };

            const compressedFile = await imageCompression(imageFile, options);
            const arr = await compressedFile.arrayBuffer();
            this.zipedData.set(elementId, new Uint8Array(arr));
            promiseHandler.invokeMethodAsync('GetDataStream'); 

        }

        public GetCompresedImageDataStream(elementId) : Uint8Array {
            return this.zipedData.get(elementId);
        }

    }

    export function Load(): void {
        window['imgCls'] = new ImageFunctions();
    }

}


JSInteropWithTypeScript.Load();