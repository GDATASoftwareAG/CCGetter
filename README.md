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

## Build & Release

CCGetter is build with an [Azure Build Pipeline](https://dev.azure.com/gdatasoftware/CCGetter/_build?definitionId=3). If a tagged commit on the master branch is pushed to the origin, a new release to Github is triggered automatically. An example how to tag and push a commit is given below.

Tag a release commit with: `git tag -a v1.0.0 -m "CCGetter v1.0.0"`.

Push the tag to the origin: `git push origin v1.0.0`

Replace the version number with the one to use.
