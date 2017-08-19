const webpack = require('webpack');
const ExtractTextPlugin = require("extract-text-webpack-plugin");
const AssetsPlugin = require('assets-webpack-plugin');
const Visualizer = require('webpack-visualizer-plugin');
const { CheckerPlugin } = require('awesome-typescript-loader');
const yargs = require('yargs');
const path = require('path');
//var HtmlWebpackPlugin = require('html-webpack-plugin');

var paths = {
    node: path.join(__dirname, "node_modules/"),
    appjs: path.join(__dirname, "Scripts/"),
    appcss: path.join(__dirname, "Content/"),
    dist: path.join(__dirname, "build/webpack")
};

var plugins = [
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
    //new HtmlWebpackPlugin({
    //    inject: false,
    //    template: path.join(__dirname, 'Views/Shared/_Layout.cshtml'),
    //    filename: path.join(__dirname, 'Views/Shared/_LayoutAfter.cshtml')
    //}),
    new Visualizer()
],
    outputFile;

if (yargs.argv.p) {
    plugins.push(new webpack.optimize.UglifyJsPlugin({ minimize: true, sourceMap: true, include: /\.min\.js$/ }));
    outputFile = '[name].min.js';
} else {
    outputFile = '[name].js';
}

var wbConfigEntries = {
    "app": paths.appjs + "App"
};

module.exports = {
    devtool: 'source-map',
    entry: wbConfigEntries,
    target: 'web',
    output: {
        path: paths.dist, // Note: Physical files are only output by the production build task `npm run build`.
        publicPath: './',
        filename: outputFile,
        library: "[name]",
        libraryTarget: "umd",
        umdNamedDefine: true
    },
    devServer: {
        colors: true,
        historyApiFallback: true,
        inline: true,
        hot: true,
        contentBase: './'
    },
    plugins: plugins,
    module: {
        rules: [
            { test: /\.js$/, exclude: /node_modules/ },
            { test: /\.css$/, use: ExtractTextPlugin.extract({ fallback: "style-loader", use: "css-loader" }) },
            { test: /\.scss$/, use: ExtractTextPlugin.extract({ fallback: 'style-loader', use: ['css-loader?sourceMap', 'sass-loader?sourceMap'] }) },
            { test: /\.eot(\?v=\d+\.\d+\.\d+)?$/, use: 'file-loader' },
            { test: /\.(woff|woff2)(\?v=\d+\.\d+\.\d+)?$/, use: 'url-loader?-loaderprefix=font/&limit=5000' },
            { test: /\.ttf(\?v=\d+\.\d+\.\d+)?$/, use: 'url-loader?limit=10000&mimetype=application/octet-stream' },
            { test: /\.svg(\?v=\d+\.\d+\.\d+)?$/, use: 'url-loader?limit=10000&mimetype=image/svg+xml' },
            { test: /\.(jpg|png|gif)$/, use: 'file-loader' },
            { enforce: 'pre', test: /\.tsx?$/, use: "awesome-typescript-loader" }
        ],
        loaders: [
            { test: require.resolve("jquery"), loader: "expose?$!expose?jQuery" }
        ]
    },
    resolve: {
        extensions: [".tsx", ".ts", ".js", ".scss", ".css"]
    }
};