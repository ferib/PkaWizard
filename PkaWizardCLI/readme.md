# PkaWizard CLI
Command line tool for PkaWizard.

# What is this?
PkaWizard is a set of tools designed to DIY secure Cisco's Packet Tracer *(version 7)*. The current versions of Packet Tracer does not keep up with modern security, making it easy to cheat exams, hence why I felt the need to create such set of tools so anyone can modify their version of Packet Tracer and reduce exam fraud.

# Goal
The goal is to patch Packet Tracer in a way that a given .pka file can ONLY be used with the patched version of Packet Tracer. This allows us to implement additional security features inside Packet Tracer. This achieved by two basic steps:
1. Patching Packet Tracer
2. Re-packing **.pka**, **.pts** and **.ptd** files

# Patching PacketTracer
Patching Packet Tracer is required to not only change the file decoding algorithm, but also to add modern security checks such as obfuscation, anti-debugging, code protection, virtualisation, etc...

For this PoC we will only focus on patching the decoding algorithm, this will demonstrate how the patched Packet Tracer can only be used with re-packed .pka files to prevent fraud.

# Re-packing Files
To make the exam files *(.pka)* and other configuration files *(.pts, ptd)* work with out patched version of Packet Tracer, it is required to re-pack those files. This is done by removing the original Packet Tracer packing algirithm and then replacing it with our own custom version.

# Examples

**Patching** Packet Tracer to remove stage 1 Reverse XOR with fixed XOR key 32
```
$ ./PkaWizardCLI.exe patch "C:\"
```
**Re-packing** all files in Packet Tracer's directory with XOR key 32 

```
$ ./PkaWizardCLI.exe repack "C:\Cisco Packet Tracer 7.2.1" -k 32
```
**Re-packing** *(restoring)* all files in Packet Tracer's directory to the backup/original content
```
$ ./PkaWizardCLI.exe repack "C:\Cisco Packet Tracer 7.2.1" -r
```
**Re-packing** a specific file to XOR key 32
```
$ ./PkaWizardCLI.exe repack -k 32 -t "C:\Cisco Packet Tracer 7.2.1"
```

# Other
You can find the whole research on my blog at https://ferib.dev/
