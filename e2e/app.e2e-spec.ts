import { MeanUploadingAppPage } from './app.po';

describe('mean-uploading-app App', () => {
  let page: MeanUploadingAppPage;

  beforeEach(() => {
    page = new MeanUploadingAppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
