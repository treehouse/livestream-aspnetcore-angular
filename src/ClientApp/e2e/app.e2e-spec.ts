import { ClientAppPage } from './app.po';

describe('client-app App', () => {
  let page: ClientAppPage;

  beforeEach(() => {
    page = new ClientAppPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
