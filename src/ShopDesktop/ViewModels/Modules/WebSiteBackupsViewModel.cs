using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dock.Model.Mvvm.Controls;
using WebSiteBackups.Contracts;

namespace ShopDesktop.ViewModels.Modules
{
    public class WebSiteBackupsViewModel : Document
    {
	    private readonly IWebSiteBackups _webSiteBackups;
	    private string _path = string.Empty;
	    private string _text = string.Empty;
	    private string _encoding = string.Empty;

	    public WebSiteBackupsViewModel(IWebSiteBackups webSiteBackups)
	    {
		    _webSiteBackups = webSiteBackups;
	    }


	    public string Path
	    {
		    get => _path;
		    set => SetProperty(ref _path, value);
	    }

	    public string Text
	    {
		    get => _text;
		    set => SetProperty(ref _text, value);
	    }

	    public string Encoding
	    {
		    get => _encoding;
		    set => SetProperty(ref _encoding, value);
	    }

	    private string _infoText;
	    /// <summary>
	    /// Output text.
	    /// </summary>
	    public string InfoText
	    {
		    get => _infoText;
		    set => SetProperty(ref _infoText, value);
	    }

	    private bool _showProgressControls;
	    /// <summary>
	    /// Отображать компоненты информирующее о прогрессе выполняемой операции.
	    /// </summary>
	    public bool ShowProgressControls
	    {
		    get => _showProgressControls;
		    set => this.SetProperty(ref _showProgressControls, value);
	    }

	    private string _progressText;
	    /// <summary>
	    /// Текст с информацией о текущей операции.
	    /// </summary>
	    public string ProgressText
	    {
		    get => _progressText;
		    set => this.SetProperty(ref _progressText, value);
	    }

	    private int _progressValue;
	    /// <summary>
	    /// Значение прогресса 0-100%.
	    /// </summary>
	    public int ProgressValue
	    {
		    get => _progressValue;
		    set => this.SetProperty(ref _progressValue, value);
	    }

		/// <summary>
		/// Begin create backup web site.
		/// </summary>
	    public void CreateBackup()
	    {
			_webSiteBackups.CreateBackup();
	    }
	}
}
