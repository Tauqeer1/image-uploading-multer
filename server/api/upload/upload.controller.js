const Upload = require('./upload.model');

module.exports = {
  index(req, res) {
    res.send('api works');
  },
  create(req, res) {
    console.log('req.body', req.body);
    let upload = {
      name: req.body.username,
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
