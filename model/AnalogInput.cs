public class AnalogInput {
    private string name;
    private string description;
    private Driver driver;
    private long IOAddress;
    private long scanTime;
    private ArrayList<Alarm> alarms;
    private bool scanOn;
    private bool autoScan;
    private double lowLimit;
    private double highLimit;
    private string units;
}