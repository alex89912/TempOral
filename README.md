# TempOral

TempOral is an interpreted programming language designed to provide a dynamic and interactive coding experience. With TempOral, your code updates in real-time as soon as you save your application. No more waiting for compilation or execution - see your changes come to life instantly!

## How it Works

TempOral is based on C#, combining the performance of a compiled language with the flexibility of real-time updating. Here's how it operates:

1. **Continuous Execution**: TempOral runs a loop that continuously checks your program for updates. As soon as your code finishes execution, it re-evaluates the source files to detect any changes.

2. **Real-Time Updates**: Once a change is detected, TempOral updates the running application without any manual intervention. You can see the effects of your code modifications instantly, without the need to restart or recompile.

3. **Seamless Integration**: TempOral seamlessly integrates into your development workflow. Write your code in your favorite text editor or IDE, and see the updates reflected in real-time as you save your files.

## Getting Started

To start using TempOral, follow these simple steps:

1. **Install TempOral**: Clone this repository and install TempOral on your machine.

2. **Write Your Code**: Use your preferred text editor or IDE to write TempOral code. TempOral syntax is intuitive and easy to learn.

3. **Save Your App**: Save your TempOral application files. As soon as you save, TempOral will update your running application to reflect the changes immediately (needs the flag `--restart-on-edit` and `--file <file name>`).

4. **Experiment and Iterate**: Explore different ideas, tweak parameters, and debug issues in real-time. TempOral empowers you to iterate rapidly and see the effects of your changes instantly.

## Example

Here's a simple example of TempOral code:

```tempo
// Print "Hello, World!" to the console
print("Hello, World!");
```

## Contributing

Contributions to TempOral are welcome! Whether you want to report a bug, suggest a feature, or submit a pull request, I will truly appreciate your involvement.

## License

TempOral is licensed under the Apache 2.0 License. See the [LICENSE](LICENSE) file for details.

