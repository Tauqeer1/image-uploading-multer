const express = require('express');
const multer = require('multer');
let storage = multer.diskStorage({
  destination: function(req, file, cb) {
    cb(null, './uploads/');
  },
  filename:  function(req, file, cb) {
    cb(null, file.originalname)
  }
});

let upload = multer({storage: storage});
const uploadController = require('./upload.controller');

const router = express.Router();
router.get('/', uploadController.index);
router.post('/', upload.single('uploadFile'), uploadController.create);

module.exports = router;
