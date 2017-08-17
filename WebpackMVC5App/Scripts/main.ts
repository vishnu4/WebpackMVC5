export default class Main {
    private _name = '';

    constructor(name: string) {
        this._name = name;
    }

    TestFunc() {
        console.log(this._name);
    }
}
