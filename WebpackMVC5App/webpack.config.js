const webpack = require('webpack');
const ExtractTextPlugin = require("extract-text-webpack-plugin");
const AssetsPlugin = require('assets-webpack-plugin');
const Visualizer = require('webpack-visualizer-plugin');
const { CheckerPlugin } = require('awesome-typescript-loader');

const path = require('path');
var paths = {
    node: path.join(__dirname, "node_modules/"),
    appjs: path.join(__dirname, "Scripts/"),
    appcss: path.join(__dirname, "Content/"),
    dist: path.join(__dirname, "build/webpack")
};

var wbConfigEntries = {
    "jqkendo": [
        paths.node + "jquery/dist/jquery.js",
        paths.node + "@progress/kendo-ui/js/kendo.web.js",
        paths.node + "@progress/kendo-ui/js/kendo.aspnetmvc.js"
    ]
}

module.exports = {
    devtool: 'source-map',
    entry: wbConfigEntries,
    target: 'web',
    output: {
        path: paths.dist, // Note: Physical files are only output by the production build task `npm run build`.
        publicPath: './',
        filename: '[name].js'
    },
    devServer: {
        colors: true,
        historyApiFallback: true,
        inline: true,
        hot: true,
        contentBase: './'
    },
    plugins: [
        new CheckerPlugin(),
        new webpack.LoaderOptionsPlugin({
            debug: true
        }),
        new webpack.NoEmitOnErrorsPlugin(),
        new ExtractTextPlugin({
            filename: '[name].css',
            disable: false,
            allChunks: true
        }),
        // allows for global variables
        new webpack.ProvidePlugin({
            $: 'jquery',
            jQuery: 'jquery',
            'window.jQuery': 'jquery'
        }),
        new Visualizer()
    ],
    module: {
        rules: [
            { test: /\.js$/, exclude: /node_modules/ },
            { test: /\.css$/, use: ExtractTextPlugin.extract({ fallback: "style-loader", use: "css-loader" }) },
            { test: /\.scss$/, use: ExtractTextPlugin.extract({ fallback: 'style-loader', use: ['css-loader?sourceMap', 'sass-loader?sourceMap'] }) },
            { test: /\.eot(\?v=\d+\.\d+\.\d+)?$/, use: 'file-loader' },
            { test: /\.(woff|woff2)(\?v=\d+\.\d+\.\d+)?$/, use: 'url-loader?-loaderprefix=font/&limit=5000' },
            { test: /\.ttf(\?v=\d+\.\d+\.\d+)?$/, use: 'url-loader?limit=10000&mimetype=application/octet-stream' },
            { test: /\.svg(\?v=\d+\.\d+\.\d+)?$/, use: 'url-loader?limit=10000&mimetype=image/svg+xml' },
            { test: /\.(jpg|png)$/, use: 'file-loader' },
            { enforce: 'pre', test: /\.tsx?$/, use: "awesome-typescript-loader" }
        ],
        loaders: [
            { test: require.resolve("jquery"), loader: "expose?$!expose?jQuery" },
        ]
    },
    resolve: {
        extensions: [".tsx", ".ts", ".js", ".scss", ".css"]
    }
};