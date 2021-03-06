const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const uploadSchema = new Schema({
  name: { type: String, default: '' },
  imagePath: { type: String, default: '' },
  created: { type: Date, default: Date.now() }
});

module.exports = mongoose.model('Upload', uploadSchema);
