import { ZapZapTemplatePage } from './app.po';

describe('ZapZap App', function() {
  let page: ZapZapTemplatePage;

  beforeEach(() => {
    page = new ZapZapTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
