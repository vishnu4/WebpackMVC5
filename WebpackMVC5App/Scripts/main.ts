import * as $ from 'jquery';
import * as bootstrap from 'bootstrap';
import '../node_modules/@progress/kendo-ui/js/kendo.web';
import '../node_modules/@progress/kendo-ui/js/kendo.aspnetmvc';
import '../node_modules/bootstrap/dist/css/bootstrap.css';
import '../node_modules/bootstrap/dist/css/bootstrap-theme.css';
import '../node_modules/font-awesome/css/font-awesome.css';
import '../node_modules/@progress/kendo-ui/css/web/kendo.common.css';

export default class Main {
    private _name = '';

    constructor(name: string) {
        this._name = name;
    }

    TestFunc() {
        console.log(this._name);
    }
}