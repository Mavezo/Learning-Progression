const evening = require("./evening")
const morning = require("./morning")

module.exports={
    getMorningMessage: function() { console.log(morning);},
    getEveningMessage: function() { console.log(evening);}
};