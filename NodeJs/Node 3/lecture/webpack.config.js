module.exports = {
    entry: "./js/profile.js",
    output: {
        filename: "./bundle.js",
        library: "myApp"
    },
    module: {
        rules: [
            {
                test: /\.css/i,
                use: [
                    { loader: "style-loader" },
                    { loader: "css-loader" }
                ]
            },
            {
                test: /\.png|jpg|jpeg|bmp/i,
                use: [
                    {loader: "file-loader"}
                ]
            }
        ]
    }
}