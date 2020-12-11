class CustomRequest{
    constructor(method, uri, version, message) {
        this.method = method;
        this.uri = uri;
        this.version = version;
        this.message = message;
        this.respone = undefined;
        this.fulfilled = false;
    }
}

function data() {
    let newData = new CustomRequest('GET', 'http://google.com', 'HTTP/1.1', '');

    console.log(newData);

}

data();