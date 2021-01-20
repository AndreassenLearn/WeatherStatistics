# WeatherStatistics
## Usage
### Start
The application can be run with arguments, like so `WeatherStatistics.exe 14,2 15,8 15,1 15`.
If these are not entered (when you for instance launch the application by clicking it) the application will ask for you to enter them after it has started instead.

### Input
The collection of measurements to be inputed into WeatherStatistics can be given in the folloewing ways:

* Integers: `15 -18 17`

* Decimals (with ',' as separator): `15,347 -18,4 16,89`

* Decimals (with '.' as separator): `15.347 -18.4 16.89`

* A mixture of it all: `15 -18,4 16.89`

If a value is invalid, it will be ignored and excluded from the calculations. *But don't ya' worry!* All the values processed by WeatherStatistics will be printed back in the console.

### Output
From the input, WeatherStatistics will calculate the average, highest, and lowest values and print them in the console.
