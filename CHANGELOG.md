# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [2.0.0]
### Added
- Changes from [Joe Coutcher](https://github.com/jcoutch/NCrontab-Advanced) v1.3.15.
- Target framework version `netstandard2.0`.
- Source link support.
- Changelog

### Changed
- Switched to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).
- Refactored project files.

### Removed
- Target framework version `net451`. `net45` will be used as fallback.

### Fixed
- [Zero Month/Day parsing](https://github.com/jcoutch/NCrontab-Advanced#11)
- [GetNextOccurrence() blows up for 29W, 30W, 31W](https://github.com/jcoutch/NCrontab-Advanced#12)
- [Correctly roll over from 58 to 59 minutes/seconds](https://github.com/jcoutch/NCrontab-Advanced#14)

## 1.2.3.3 - 2017-12-15
### Added
- First release as signed fork of [Joe Coutcher](https://github.com/jcoutch/NCrontab-Advanced) v1.2.3.3.


[Unreleased]: https://github.com/visualon/NCrontab-Advanced/compare/v2.0.0...HEAD
[2.0.0]: https://github.com/visualon/NCrontab-Advanced/compare/v1.2.3.3...v2.0.0
