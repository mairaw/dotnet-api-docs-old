            // Set the maximum number of ServicePoint instances to 
            // maintain. If a ServicePoint instance for that host already 
            // exists when your application requests a connection to
            // an Internet resource, the ServicePointManager object
            // returns this existing ServicePoint instance. If none exists 
            // for that host, it creates a new ServicePoint instance.
            ServicePointManager.MaxServicePoints = 4;

            // Set the maximum idle time of a ServicePoint instance to 10 seconds.
            // After the idle time expires, the ServicePoint object is eligible for
            // garbage collection and cannot be used by the ServicePointManager object.
            ServicePointManager.MaxServicePointIdleTime = 10000;
