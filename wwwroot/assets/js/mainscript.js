function main() {
    //store obj ref
    /*let obj = "";*/
    //store result value
    /*let result;*/
    let chooseFile = "";
    chooseFile = document.getElementById("imageUpload");
    chooseFile.addEventListener("change", getImgData);
    function getImgData() {
        const files = chooseFile.files[0];
        if (files) {
            const fileReader = new FileReader();
            fileReader.readAsDataURL(files);
            fileReader.addEventListener("load", function () {
                /*result = this.result;*/
                /*CallCsharpreturn();*/
                localStorage.setItem("img", this.result);
            });
        }
    }
    //window.JsFunctions = {
    //    SuccessFunc: function callme(objref) {
    //        obj = objref;
    //    }
    //}
    //function CallCsharpreturn() {
    //    obj.invokeMethodAsync('GetImgValue', result);
    //}
}