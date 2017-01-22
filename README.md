# WindowGrid(WPF Window embed to Windows Forms Control)

![WPF Window embed to Windows Forms Control Sample][sample]

[sample files download][down]
*startup WindowsFormsApplication.exe*

# Require

.Net Framework:4.0 +

# Methods

- WindowGrid(Window window)
  >instanced method,init WindowGrid.

- WindowGrid.Init(Window window)
  >instanced method,init WindowGrid when instantiation WindowGrid object without arguments.

- WindowGrid.GetHost<T>(T t)
  >static method,return ElementHost object.

# Usage

1 Add References

>add below dll to Windows Forms application.

  - PresentationCore.dll
  - PresentationFramework.dll
  - System.Xaml.dll
  - WindowGrid.dll
  - WindowsBase.dll
  - WindowsFormsIntegration.dll

![Add References][ref]

2 Coding

```cs
//using namespace
using XY.UI;

this.panel2.Controls.Clear();

this.panel2.Controls.Add(WindowGrid.GetHost<MainWindow>());

//or
//ElementHost host = WindowGrid.GetHost<MainWindow>();
//this.panel2.Controls.Add(host);

//or
//MainWindow window = new MainWindow();
//ElementHost host = WindowGrid.GetHost<MainWindow>(window);
//this.panel2.Controls.Add(host);
```

# Bug

Not support .net framework < 4.0 in my way.

# License

[MIT License](https://github.com/seayxu/WindowGrid/blob/master/LICENSE)

[sample]:https://github.com/seayxu/WindowGrid/raw/master/assets/sample.gif
[ref]:https://github.com/seayxu/WindowGrid/raw/master/assets/references.jpg
[down]:https://github.com/seayxu/WindowGrid/raw/master/assets/WindowGrid.sample.bin.zip