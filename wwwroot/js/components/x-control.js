var pomodoro = {
    minutes: 0,
    seconds: 0,
    started: false,
    minutesDom: null,
    secondsDom: null,
}

xtag.register('x-control', {
    lifecycle: {
        created: function () {
            var controllButtons = this._intializeControlButtons();
            this.innerHTML = controllButtons;
        },
        inserted: function () {
            var self = this
            pomodoro.minutesDom = document.querySelector('#minutes');
            pomodoro.secondsDom = document.querySelector('#seconds')
            setInterval(function () { self._intervalCallback(self); }, 1000);
        },
    },
    methods: {
        _intializeControlButtons: function () {
            var controls = '<div id="startTimer" class="center positive ui button">Start</div>' +
                           '<div id="stopTime" class="center negative ui button">Stop</div>' +
                            '<div id="break" class="center positive ui button">Break</div>';
            return controls;
        },

        _startTime: function () {
            this._resetVariables(25, 0, true);
        },
        _startBreak: function () {
            this._resetVariables(5, 0, true);
        },
        _stopTimer: function () {
            this._resetVariables(25, 0, false);
            this._updateDom();
        },
        _toDoubleDigit: function (num) {
            if (num < 10) {
                return "0" + parseInt(num, 10);
            }
            return num;
        },
        _resetVariables: function (mins, secs, started) {
            pomodoro.minutes = mins;
            pomodoro.seconds = secs;
            pomodoro.started = started;
        },

        _timerComplete: function () {
            pomodoro.started = false;
        },

        _updateDom: function () {
            pomodoro.minutesDom.innerHTML = this._toDoubleDigit(pomodoro.minutes);
            pomodoro.secondsDom.innerHTML = this._toDoubleDigit(pomodoro.seconds);
        },

        _intervalCallback: function (context) {
            var self = context;
            if (!pomodoro.started) return false;
            if (pomodoro.seconds == 0) {
                if (pomodoro.minutes == 0) {
                    self._timerComplete();
                    return;
                }
                pomodoro.seconds = 59;
                pomodoro.minutes--;
            } else {
                pomodoro.seconds--;
            }
            self._updateDom();
        },

    },
  
    events: {
        'click:delegate(.ui.button#startTimer)': function (e) {
            this.parentElement._startTime()
        },
        'click:delegate(.ui.button#stopTime)': function (e) {
            this.parentElement._stopTimer()
        },
        'click:delegate(.ui.button#break)': function (e) {
            this.parentElement._startBreak()
        },
    }
});