var pathSite = "";

function GetPathSite() {
    return this.pathSite;
};

function SetPathSite(pathSite) {
    this.pathSite = pathSite;
};

var pathLocalhost = window.location.protocol + "//" + window.location.hostname + "/";
pathSite = (pathLocalhost === "http://localhost/") ? "http://localhost:8771/" : pathSite;
pathSite = (pathLocalhost === "http://test.multistrategy.co/") ? "http://test.multistrategy.co/UniPolla/" : pathSite;
pathSite = (pathLocalhost === "https://www.unicentromedellin.com.co/") ? "https://www.unicentromedellin.com.co/unipolla/" : pathSite;

