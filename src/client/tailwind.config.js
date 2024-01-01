/** @type {import('tailwindcss').Config} */
export default {
	content: ['./**/*.{razor,html}'],
	theme: {
		extend: {},
	},
	plugins: [require('daisyui')],
	daisyui: {
		theme: ['light'],
	},
}

