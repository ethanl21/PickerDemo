# Picker Demo for PR Review

Demonstrates the modified UIButton+Menu picker from my fork.

- **Fork:** https://github.com/ethanl21/maui
- **Branch:** `catalyst-picker`

## Prerequisites

- .NET 10.0 SDK
- Xcode 26.0
- iOS Simulator 20+ or macOS Catalyst

## Setup

### Option A: Build Local Packages

1. Clone my fork and checkout branch:
   ```bash
   git clone https://github.com/ethanl21/maui.git
   cd maui
   git checkout catalyst-picker
   ```

2. Build packages:
   ```bash
   git checkout 0e0ec396fe
   dotnet cake --configuration=Release --pack --skip-android --skip-windows
   ```
   Copy `.nupkg` files to `packages/`

3. Return to branch: `git checkout catalyst-picker`

### Option B: Use Official NuGet Packages

Edit `NuGet.config` to only use NuGet:
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="nuget" value="https://api.nuget.org/v3/index.json" />
  </packageSources>
</configuration>
```

This uses the original upstream picker.

## Building

```bash
dotnet restore
dotnet build

# Run on iOS Simulator
dotnet run -f net10.0-ios26.0 -p:RuntimeIdentifier=iossimulator-arm64

# Run on macOS Catalyst
dotnet run -f net10.0-maccatalyst26.0
```

## Test Cases

1. Basic Picker (3-5 items)
2. Picker with Title
3. Styled Picker (font/color)
4. Picker with Many Items (50 US States)
5. Pre-selected Picker

## Expected Differences

| Feature     | Original              | Modified                              |
| ----------- | --------------------- | ------------------------------------- |
| Interaction | Alert modal + wheel  | Button + popover menu               |
| Keyboard    | Arrow keys scroll wheel | Arrow keys / type to select     |

## Related

- Fork: https://github.com/ethanl21/maui
- Branch: `catalyst-picker`