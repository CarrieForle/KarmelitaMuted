UnityExplorer is the absolutely goat.

I must read [Harmony doc](https://harmony.pardeike.net/articles/patching.html) especially the Injection part. It took me more than an hour to resolve ambiguous patching error which I can completely avoid by reading the documentation correctly.

I need to implement a hotkey to toggle muting, which means I probably should've gone to set the volume to zero rather than skipping `AudioSource.PlayScheduled()` entirely. Welp.