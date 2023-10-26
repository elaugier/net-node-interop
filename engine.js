"use strict";

const { Engine } = require("json-rules-engine");

module.exports = {
  getEngineResult: async (rules, facts) => {
    console.log("rules => ", rules);
    console.log("facts => ", facts);
    let engine = new Engine(JSON.parse(rules));
    let r = await engine.run(JSON.parse(facts));
    let result = JSON.stringify(r);
    return { result: result };
  },
};
