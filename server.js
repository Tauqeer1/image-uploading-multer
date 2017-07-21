const express = require('express');
const path = require('path');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const morgan = require('morgan');

const config = require('./server/config/config');

const port = process.env.PORT || 3000;

mongoose.connect(config.mongoURL);
mongoose.connection.on('error', (err) => {
  console.error(`mongodb connection error ${err}`);
  process.exit(-1);
});

const app = express();

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: false}));
app.use(morgan('dev'));

app.use(express.static(path.join(__dirname, 'dist')));

app.use('/api/upload', require('./server/api/upload'));

app.get('*', (req, res) => {
  res.sendFile(path.join(__dirname, 'dist/index.html'));
});

app.listen(port, () => {
  console.log(`Listening on port ${port}`);
});
