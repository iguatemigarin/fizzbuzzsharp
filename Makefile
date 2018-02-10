clean:
	rm -rf bin

build: clean
	fsharpc FizzBuzz.fs Main.fs \
		--nologo \
		--out:./bin/fizzbuzzsharp \
		--target:exe \
		--nocopyfsharpcore \
		--standalone

run:
	mono ./bin/fizzbuzzsharp
