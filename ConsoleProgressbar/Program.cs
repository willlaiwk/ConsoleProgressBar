using ConsoleProgressBar;

var progressbar = new ProgressBar();

var total = 80;

for (int i = 1; i <= total; i++)
{
    progressbar.Show(i, total);
    Thread.Sleep(50);
}
