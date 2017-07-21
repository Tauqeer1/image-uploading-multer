module.exports = {
  jwtSecret: 'jwtsecretofmeanapp',
  mongoURL: process.env.MONGODB_URI || 'mongodb://localhost:27017/mean-upload',
  port: process.env.PORT || 8000
};
