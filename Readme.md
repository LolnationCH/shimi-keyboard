# Shimi's Keyboard

This program aims to automatically change your keyboard layout, based on what keyboard is plugged in. **This program is Windows ONLY.**

## How does it work

The program checks every 5 seconds what keyboard is plugged in the computer. Then, based on it's identifier (and the configuration you make), make changes to the Windows Keyboard Layout.

This can be useful if you use a dedicated keyboard for a certain language, and don't want the hassle of changing the layout when you plug it in.

## How to use

Run the program once with the keyboard you want to change the layout plugged in, with the layout you want to change to.
This will create a config.json file with the information of the current keyboard.

Open this file with text editor, you should see something like this :

```json
[
  {
    "Layout": "00000409",
    "DeviceID": "USB\\XXXXXX|X|NFINEFINFENIFN",
    "PostMessage": "Switching to United States"
  }
]
```

- Layout is the keyboard layout to use, you can look up the code you want here : [[MS-LCID]: Windows Language Code Identifier (LCID) Reference](https://learn.microsoft.com/en-us/openspecs/windows_protocols/ms-lcid/70feba9f-294e-491e-b6eb-56532684c37f).
You need to add 4 zero's at the beginning of the code. In the example, 0409 is the code for us_EN.
- DeviceID is the Identifier of the keyboard. You should not change this unless you know what you are doing.
- PostMessage is for debug purpose, but you should use it to say which language you switch.

Once you have change the file, the next time you run the program, it will activate it's mechanism.

## Contribution

You can build this program using dotnet cli. You can signal bugs in the issue tab.

## License

This project uses MIT.
