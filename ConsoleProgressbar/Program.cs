using ConsoleProgressbar;

var progressbar = new Progressbar();

var total = 80;

for (int i = 1; i <= total; i++)
{
    progressbar.Write("Do something...", i, total);
    Thread.Sleep(100);
}
