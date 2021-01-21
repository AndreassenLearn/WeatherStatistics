# WeatherStatistics
## Usage
### Start
The application can be run with arguments, like so `WeatherStatistics.exe statistics 14,2 15,8 15,1 15`.
If these are not entered (when you for instance launch the application by clicking it) the application will be ready for you to enter commands right after it starts instead.

### Commands
#### `statistics [add] <measurement1> <measurement2> ... <measurementN>`
*Calculate the average, highest, and lowest value from a collection of measurements.*

The collection of measurements can be given in the following ways:

* Integers: `15 -18 17`

* Decimals (with ',' as separator): `15,347 -18,4 16,89`

* Decimals (with '.' as separator): `15.347 -18.4 16.89`

* A mixture of it all: `15 -18,4 16.89`

If a value is invalid, it will be ignored and excluded from the calculations. *But don't ya' worry!* All the values processed by WeatherStatistics will be printed back in the console as well as those that were invalid.

Values starting with either ',' or '.' will be treated as if they were starting with zero. Moreover this is also possible with negative values; `-,3` would translate into `-0,3`.

By adding the keyword 'add', measurements from the previous ran statistics command will be kept.

##### Example
```
statistics 21,2 abc 17 25,6 ,9

ADDED MEASUREMENTS:
21,2
17
23,6
0,9

INVALID ARGUMENTS (IGNORED):
abc

SUMMARY:
Average: 15,675
High: 23,6
Low: 0,9
```

### Versions
#### v1.1.0
* New code structure - ready for custom commands.
* Added help message.

#### v1.0.0
* Initial version.
