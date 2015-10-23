# TestAppFabricCache
Simple Application for Testing of AppFabric Cache

Usage:

Following command is used to test cache:

pingcache cachename key value

cachename: The name of the cache, which should be tested.
key: The key which will be used to insert the item in the cache.
value: The value which will be added to cache for specified key.

Example:
Following command will connect to 'default' cache and add the value 'cool' for key 'daenet'.

pingcache default daenet cool

This is testing code:

DataCache mycache = dcf.GetCache(cachename);
mycache.Add(key, val);
