xtag.register('x-pomodoro', {
    lifecycle: {
        inserted: function () {
            var containerElem = this._buildContainer();
            this.innerHTML = containerElem;
        },
        removed: function () {
            alert('I fire when an ‹x-foo› is REMOVED from the DOM');
        },
        attributeChanged: function (attrName, oldValue, newValue) {
            alert('I fire when an ATTRIBUTE is CHANGED on an ‹x-foo›');
        }
    },
    methods: {
        _buildContainer: function () {
            var container = '<div class="ui raised very padded text container segment">' +
                                     `<div id="clock"><span id="minutes">25</span>:<span id="seconds">00</span></div>` +
                                         '<x-control></x-control>'+
                                     '</div>'+
                             '</div>';
            return container;
        },

    }
});