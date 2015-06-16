using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Shadowsocks.Controller
{
    public class Atom64
    {
        private Int64 val;
        public Atom64()
        {
            val = 0;
        }
        public Atom64(Int64 iniVal)
        {
            val = iniVal;
        }
        public Atom64 add(Int64 n )
        {
            Interlocked.Add(ref val, n);
            return this;
        }
        public Atom64 decrement()
        {
            Interlocked.Add(ref val, -1);
            return this;
        }
        public Atom64 increment()
        {
            Interlocked.Add(ref val, 1);
            return this;
        }

        /// <summary>
        /// set value,return the old value
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Int64 setVal(Int64 n)
        {
            return Interlocked.Exchange(ref val,n); 
        }
        public Int64    getVal()
        {
            return Interlocked.Read(ref val); 
        }
 
    }
    public class PerfCounter
    {
        private Atom64 bytesSent=new Atom64();
        private Atom64 bytesReceived = new Atom64();

        public PerfCounter()
        {
            reset();
        }

        public Atom64 getSentBytes()
        {
            return bytesSent;
        }
        public Atom64 getReceivedBytes()
        {
            return bytesReceived; 
        }
        public void reset()
        {
            bytesSent.setVal(0);
            bytesReceived.setVal(0);
        }
        public static String   formatByteString(Int64 n)
        {
            Int64 ONE_KB =  1024;
            Int64 ONE_MB = ONE_KB * 1024;
            Int64 ONE_GB = ONE_MB * 1024;
            if (n < ONE_KB)
            {
                // format to bytes
                return n.ToString() + " Bytes";
            }
            else if (n >= ONE_KB && n<ONE_MB)
            {
                // format to KB
                Double percnt = ((Double)n) / ONE_KB;
                return percnt.ToString("0.000") + " KB"; 
            }
            else if (n >= ONE_MB && n < ONE_GB)
            {
                // format to MB
                Double percnt = ((Double)n) / ONE_MB;
                return percnt.ToString("0.000") + " MB"; 
            }
            else 
            {
                // format to GB
                Double percnt = ((Double)n) / ONE_GB;
                return percnt.ToString("0.000") + " GB"; 
            }
        }
    }
}
