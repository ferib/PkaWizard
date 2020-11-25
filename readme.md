# What is this?
PkaWizard is a set of tools designed to DIY secure Cisco's Packet Tracer *(version 7.2)*. The current versions of Packet Tracer does not keep up with modern security, making it easy to cheat exams, hence why I felt the need to create such a set of tools so anyone can modify their version of Packet Tracer to increase security and reduce exam fraud.

![Modern problems require modern solutions](https://github.com/ferib/PkaWizard/blob/master/notes/meme.jpg?raw=true)

## Goal
The goal is to patch Packet Tracer in a way that a given .pka file can ONLY be used with the patched version of Packet Tracer. This allows us to implement additional security features inside Packet Tracer. This achieved by two basic steps:
1. Patching Packet Tracer
2. Re-packing **.pka**, **.pts** and **.ptd** files

# Solutions
- **PkaWizard** - Web based interface
- **PkaWizardCLI** - Command line interface
- **PkaWizardLib** - Core

## TL;DR
The purple lines represent actions that come from my PkaWizard toolset:

![Modern problems require modern solutions](https://github.com/ferib/PkaWizard/blob/master/notes/packet_tracer_packer_info.png?raw=true)

- **Re-packing** functionality is used to convert an original .pka file to a custom encoded version *(or vise versa)*
- **Patching** functionality is used to patch a custom algorithm inside an original PacketTracer binary *(or vise veras)*

# Research
The full research can be found [here](https://ferib.dev/blog.php?l=post/Protecting_Packet_Tracer_Myself_Because_No_One_Gives_a_Fuck)