# What is this?
PkaWizard is a set of tools designed to DIY secure Cisco's Packet Tracer *(version 7.2)*. The current versions of Packet Tracer does not keep up with modern security, making it easy to cheat exams, hence why I felt the need to create such a set of tools so anyone can modify their version of Packet Tracer and reduce exam fraud.

## Goal
The goal is to patch Packet Tracer in a way that a given .pka file can ONLY be used with the patched version of Packet Tracer. This allows us to implement additional security features inside Packet Tracer. This achieved by two basic steps:
1. Patching Packet Tracer
2. Re-packing **.pka**, **.pts** and **.ptd** files

# Solutions
- PkaWizard - Web based interface
- PkaWizardCLI - Command line interface
- PkaWizardLib - Core

# Research
The full research can be found [here](https://ferib.dev/blog.php?l=post/Protecting_Packet_Tracer_Myself_Because_No_One_Gives_a_Fuck)