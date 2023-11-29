# WAL - Windows Auto Lock
## WAL - Windows Auto Lock
### Overview
> This simple console application written in C# provides an automated way to lock your Windows computer when the specified Bluetooth device is out of range or not available. It operates in the background, constantly monitoring the presence of the specified Bluetooth device. Once the device is no longer in range or is unavailable, the program triggers the Windows lock screen.

### Features
- **Bluetooth Monitoring:** Constantly checks the availability and proximity of the specified Bluetooth device.
- **Auto Lock:** Initiates the Windows lock screen when the specified device is out of range or not available.
- **Configuration:** Easily configure the Bluetooth device to monitor by editing the configuration file.

### Prerequisites
`.NET Runtime installed on the Windows machine.`

### Getting Started
1. Clone the repository to your local machine.
```
git clone https://github.com/your-username/bluetooth-auto-lock.git
```
2. Open the project in your preferred C# IDE.
3. Edit the `AutoLock.cfg` file to set the Bluetooth device details.
```
Devil,10F605245646
```
4. Build the project.
5. Run the executable generated by the build.
```
./BluetoothAutoLock.exe
```

### Troubleshooting
If you encounter any issues or have questions, please check the FAQ or open an issue.
