# MAUI Shell Missing Navigating events on Windows bug


# Expected

When you navigate you always get a Navigating event and after that the Navigated event

# Actual

Works on Android but does not work on Windows. On Windows, navigating to a shell root page does not raise the navigating event

# Repro

- Start the app on Windows in Debug mode (-> check the debug output since we log it there)
- Click Events in tabbar -> Only navigated event raised, navigating event is missing
- Click Go to details page button -> Both events are correctly raised
- Click the back button -> both events are correctly raised
- Click the Dummy1 in tabbar -> Only navigated event raised, navigating event is missing

