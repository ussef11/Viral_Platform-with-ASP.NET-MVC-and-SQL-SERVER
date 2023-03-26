import { initializeApp } from "https://www.gstatic.com/firebasejs/9.9.2/firebase-app.js";
import { getAnalytics } from "https://www.gstatic.com/firebasejs/9.9.2/firebase-analytics.js";

const firebaseConfig = {
    apiKey: "AIzaSyDDKcck7SLk-Vr8SBhpwJ838sPKsWf3OmU",
    authDomain: "stockimg-3472a.firebaseapp.com",
    databaseURL: "https://stockimg-3472a-default-rtdb.firebaseio.com",
    projectId: "stockimg-3472a",
    storageBucket: "stockimg-3472a.appspot.com",
    messagingSenderId: "192241779694",
    appId: "1:192241779694:web:da90eb0fdd2231341044ff",
    measurementId: "G-EFNEQJ1WSZ"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const analytics = getAnalytics(app);

import { getStorage, ref as Sref, uploadBytesResumable, getDownloadURL } from "https://www.gstatic.com/firebasejs/9.9.2/firebase-storage.js"



var files = [];
var reader = new FileReader();
var ph = document.createElement("img")
var link
var namebox = document.getElementById("namebox")
var extimg = document.getElementById("extension")

var barprog = document.getElementById("Progress")
var editor = document.getElementById("editor")
var urlupload = document.getElementById("urlupload")


var input = document.createElement("input");
input.type = "file"




input.onchange = e => {
    files = e.target.files

    var extension = GetFileExt(files[0])
    var Name = GetFileName(files[0])

    namebox.value = Name;
    extimg.innerHTML = extension;
    reader.readAsDataURL(files[0])
}




function GetFileExt(file) {
    var temp = file.name.split('.');
    var ext = temp.slice((temp.lenght - 1), (temp.lenght))
    return "." + ext[0];
}

function GetFileName(file) {
    var temp = file.name.split('.');
    var fname = temp.slice(0, -1).join(".")
    return fname;
}

async function UploadProcess() {
    var ImgToUpload = files[0];


    var ImgName = namebox.value + extimg.innerHTML;

    const metadata = {
        contentType: 'image/jpeg',

    };

    const storage = getStorage();
    const storageRef = Sref(storage, "Images/" + ImgName);

    const UploadTask = uploadBytesResumable(storageRef, ImgToUpload, metadata)

    UploadTask.on('state-changed', (snapshot) => {
        var progress = (snapshot.bytesTransferred / snapshot.totalBytes) * 100;
        barprog.innerHTML = progress + '%'
    },
        (error) => {
            alert("Error image Not Uploded");
        },
        () => {
            // Upload completed successfully, now we can get the download URL
            getDownloadURL(UploadTask.snapshot.ref).then((downloadURL) => {
                console.log('File available at', downloadURL);
                urlupload.value = downloadURL
                
                ph.src = urlupload.value
            })
        }
    );
}



reader.onload =  function () {
    link = reader.result;
    console.log(link);
    UploadProcess();
}



var a = document.getElementById("btn")
$(document).ready(function () {
    a.onclick = function () {
        input.click();
        editor.append(ph)
    }
});





