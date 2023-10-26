"use strict";

const { Engine } = require("json-rules-engine");

module.exports = {
  getEngineResult: async (callback, rules, facts) => {
    let engine = new Engine(JSON.parse(rules));
    let r = await engine.run(JSON.parse(facts));
    let result = JSON.stringify(r);
    callback(null, { result: result });
  },
};
