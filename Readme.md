# MAUI Shell Tabbar visibility on Windows bug

The events detail page has the Shell.TabBarIsVisible set to false.
All other pages have it not set since true is default.

# Expected

The tabbar is always visible except if your are on the events detail page

# Actual

Works on Android but does not work on Windows. The tabbar is still visible in the events page but will dissappear if you navigate to another root page locking you into the menu and you have to force close the app.

# Repro

- Start the app on Windows
- Click Events in tabbar
- Click Go to details page button
- You are on the detail page -> the tabbar is still visible but should not
- Click Dumm1 on tabbar
- Click Events in tabbar -> you are on the event details page now but the tabbar is gone. You can click back so you are on the event page but still the tabbar is not visible and you have to close app since you cannot navigate any more

