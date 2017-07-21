const Upload = require('./upload.model');
// import config from '../../config/config';
const multer = require('multer');
var DIR = './uploads/';
var upload = multer({dest: DIR}).single('image');

module.exports = {
  index(req, res) {
    res.send('api works');
  },
  create(req, res) {
    let upload = {
      imagePath: req.file.path
    };
    Upload.create(upload)
      .then(uploaded => {
        return res.status(200).json({ success: true, data: uploaded, error: null });
      })
      .catch(err => {
        console.error('err', err);
        return res.status(400).json({ success: false, data: null, error: err });
      });
  }
};
