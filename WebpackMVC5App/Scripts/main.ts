export default class Main {
    private _randomString = '';
    private _urlprefix = '';
    constructor(randomString: string, urlprefix: string) {
        this._randomString = randomString;
        this._urlprefix = urlprefix;
    }

    TestFunc() {
        console.log(this._randomString);
        console.log(this._urlprefix);
    }

    public LoadKendoGrid() {
        $("#basicKendo").kendoGrid({
            dataSource: {
                transport: {
                    read: this._urlprefix + "api/homeapi/getnfpadata"
                }
            },
            groupable: false,
            sortable: true,
            columns: [{
                field: "ID"
            }, {
                field: "Name",
            }, {
                field: "NFPAType",
                title: "Type",
                width: 150
            }, {
                field: "Description"
            }]
        });
    }

}
