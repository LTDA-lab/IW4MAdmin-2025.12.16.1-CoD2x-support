# IW4MAdmin – Call of Duty 2x Compatibility

This is a modified version of **IW4MAdmin 2025.12.16.1** with support for **Call of Duty 2x (CoD2x)** dedicated servers.

The modification adds CoD2x RCON and event parsing support, including proper handling of signed decimal player GUIDs and working Kick, Permanent Ban, and Temporary Ban commands.

## Installation

**Important:** This modified DLL is designed specifically for **IW4MAdmin version 2025.12.16.1**. It is not guaranteed to work with other IW4MAdmin versions.

### 1. Replace the DLL

1. Stop IW4MAdmin.
2. Navigate to your IW4MAdmin installation directory.
3. Open the `Lib` folder.
4. Back up your original `IW4MAdmin.dll`.
5. Replace it with the modified `IW4MAdmin.dll` provided in this repository.

The file to replace is:

`IW4MAdmin/Lib/IW4MAdmin.dll`

### 2. Configure your CoD2x server

Open your server's `Configuration.json` file and set the following values:

```json
"RConParserVersion": "CoD2x",
"EventParserVersion": "CoD2x"
```

Make sure both parser versions are set to `CoD2x`.

### 3. Restart IW4MAdmin

Start IW4MAdmin again. Your CoD2x server should now be recognized using the custom parsers.

## Supported Features

- CoD2x RCON parsing.
- CoD2x game event parsing.
- Signed decimal player GUID support.
- Player Kick.
- Permanent Ban.
- Temporary Ban.

## Requirements

- IW4MAdmin **2025.12.16.1**.
- A working Call of Duty 2x dedicated server.
- .NET 8 runtime.

## Disclaimer

This is a community modification of IW4MAdmin intended to provide compatibility with CoD2x dedicated servers. It is not an official IW4MAdmin release and is not affiliated with or endorsed by the IW4MAdmin or CoD2x developers.

The modified DLL is provided for the specific IW4MAdmin version listed above.


<img width="666" height="423" alt="2026-10-31 18_38_26-Window" src="https://github.com/user-attachments/assets/955f80d1-8ea7-4a17-87d1-c4e673fb099a" />
