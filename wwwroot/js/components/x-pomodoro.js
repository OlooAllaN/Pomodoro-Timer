xtag.register('x-pomodoro', {
    lifecycle: {
        created: function () {
            alert('I fire when an ‹x-foo› is CREATED');
        },
        inserted: function () {
            alert('I fire when an ‹x-foo› is INSERTED to the DOM');
        },
        removed: function () {
            alert('I fire when an ‹x-foo› is REMOVED from the DOM');
        },
        attributeChanged: function (attrName, oldValue, newValue) {
            alert('I fire when an ATTRIBUTE is CHANGED on an ‹x-foo›');
        }
    },
});