import * as $ from 'jquery';
import * as bootstrap from 'bootstrap';
import '@progress/kendo-ui/js/kendo.web';
import '@progress/kendo-ui/js/kendo.aspnetmvc';
import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap/dist/css/bootstrap-theme.css';
import 'font-awesome/css/font-awesome.css';
import '@progress/kendo-ui/css/web/kendo.common.css';
import "@progress/kendo-ui/css/web/kendo.blueopal.css";
import "../Content/Site.scss";

import Main from './main';

declare global {
    interface Window { RandomWebConfigValue: string; }
}

const mn = new Main(window.RandomWebConfigValue);
mn.TestFunc();