// const _ = require("underscore");
// const $ = require("jquery");

import _ from "underscore";
import $ from "jquery";
import Photo from "../images/image.jpg"

function timeline(user) {
    this.setHeader = function () {
        $("#timelineHeader").append(`<h1>${user.name}</h1>`);
    }
    this.setMessages = function () {
        _.each(user.messages, (message) => {
            $("#timelineMessages").append(`<li class="user-message">${message}</li>`);
        });
    }
    this.setImage = function () {
        let image = new Image();
        image.src = Photo;
        $("#timelineImage").append(image);
    }
}

export default timeline;