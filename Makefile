clean:
	rm -rf bin publish

build: clean
	fsharpc FizzBuzz.fs Main.fs \
		--nologo \
		--out:./bin/fizzbuzzsharp \
		--target:exe \
		--nocopyfsharpcore

publish: clean
	fsharpc FizzBuzz.fs Main.fs \
		--nologo \
		--out:./publish/fizzbuzzsharp \
		--target:exe \
		--nocopyfsharpcore \
		--standalone

run:
	mono ./bin/fizzbuzzsharp
