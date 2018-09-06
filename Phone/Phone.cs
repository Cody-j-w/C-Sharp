using System;

namespace Phone{

    public abstract class Phone
    {
        string _versionNumber;
        int _batteryPercentage;
        string _carrier;
        string _ringTone;
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }
        public abstract void DisplayInfo();
        public string Version
        {
            get { return _versionNumber;}
        }
        public int Battery
        {
            get { return _batteryPercentage;}
        }
        public string Carrier
        {
            get { return _carrier;}
        }
        public string Tone
        {
            get { return _ringTone;}
        }
    
    }

    public interface IRingable
    {
        string Ring();
        string Unlock();
    }

    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone){}
        public string Ring()
        {
            return Tone;
        }

        public string Unlock()
        {
            return $"Nokia {Version} unlocked with a lockpick and some elbow grease.";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~");
            Console.WriteLine($"Nokia {Version}");
            Console.WriteLine($"Battery Percentage: {Battery}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {Tone}");
            Console.WriteLine("~~~~~~~~~~~~~~~");
            Console.WriteLine("");
        }
    }

    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone){}

        public string Ring()
        {
            return Tone;
        }

        public string Unlock()
        {
            return $"Samsung Galaxy {Version} unlocks with a micro-USB emblazoned with the image of a skeleton, found submerged in the ever-moist tears of a unicorn in a crater on Io, no larger than your bedroom. Or a PIN. Your call.";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("%%%%%%%%%%%%%%%");
            Console.WriteLine($"Galaxy {Version}");
            Console.WriteLine($"Battery Percentage: {Battery}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {Tone}");
            Console.WriteLine("%%%%%%%%%%%%%%%");
            Console.WriteLine("");
        }
    }

    
}