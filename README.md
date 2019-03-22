# CCGetter

[![Build](https://img.shields.io/azure-devops/build/gdatasoftware/CCGetter/3.svg)](https://dev.azure.com/gdatasoftware/CCGetter/_build?definitionId=3)

CCGetter is a console application for Windows and Linux (both x64) that pulls a list of prevalent **command-and-control** hosts and similar malware related infrastructure.

The list is updated frequently (in average every 15min) and contains only host which we have seen in the last six month.

## Example Data

Examples for malware infrastructure host:

```none
augykqeoya.info
ayqusaiq.info
wmiqweiq.biz
wckresuiwcymao.biz
```

Currently only domains (no IPs or URLs) are available, but other entities can be created on request.

## Usage

You find the newest version of the tool on the [GitHub Release](https://github.com/GDATASoftwareAG/CCGetter/releases) page. To display help and available option see below.

On Windows (Powershell or CMD):

```powershell
CCGetter.exe --help
```

On Linux (Bash or similar):

```bash
CCGetter --help
```

## How to get credentials

If you are interested in the data as a paid service or for evaluation purposes, please contact: info@gdata.de
