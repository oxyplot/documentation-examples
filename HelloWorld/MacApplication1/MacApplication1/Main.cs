using System;

using AppKit;

namespace MacApplication1
{
    static class MainClass
    {
        static void Main (string[] args)
        {
            NSApplication.Init ();
            NSApplication.Main (args);
        }
    }
}
